USE TRBILLS
Declare @today as date = cast(getdate() as date)

Declare @adjustments as int = 668 --sophie daycare and car damage +CC paid(18)


Declare @FundsInKeyToday as numeric(18,2) = (Select KeyBalance - @adjustments from keybalance) 
Declare @days as int = 365

--Select @FundsInKeyToday, @adjustments

;If object_id('tempdb..#dateofeachbill') is not null drop table #dateofeachbill
;with base as
(
select *
,row_number() over(partition by [DATE] order by [DATE]) OnePayDayPerDate
from monthlybill mb
)



Select *
,case when [day] % 14 = 1 and (OnePayDayPerDate = 1 or onepaydayperdate is null) then 'TonyPayDay'
	 when [day] % 14 = 8 and (OnePayDayPerDate = 1 or onepaydayperdate is null) then 'CrystalPayDay'
end as [PayDay] 
into #dateofeachbill
 from base b
--order by cast(date as int)
full outer join dbo.dates dod
on datepart(d, dod.thedate) = b.Date 



;If object_id('tempdb..#final') is not null drop table #final
Select 
theDate
,Bill
,Cost
,Amount as BringHome 
,[DayOfWeek]
into #final
from #dateofeachbill doeb
left join dbo.bringhomepay bhp on bhp.name = doeb.payday and thedate > @today

--Select * from #final
--Select * from dbo.BringHomePay


Declare @start as date = (Select max(thedate)from #final where thedate <= @today and [dayofweek] = 'Friday')
Declare @end as date = dateadd(d, @days, @start)



;If object_id('tempdb..#reportstart') is not null drop table #reportstart
Select * into #reportstart from #final where thedate between @today and @end


;If object_id('tempdb..#Mondays') is not null drop table #Mondays
;with base as 
(
Select distinct thedate 
from #reportstart where dayofweek = 'Monday'
)


Select thedate,row_number() over(order by thedate) ord
into #Mondays
from base --where dayofweek = 'Monday'



Declare @i as int = 1
Declare @weeks as int =(Select count(*) from #reportstart
where [dayofweek] = 'Monday')
while @i <= @weeks 
begin
--Select * from WeeklyBill
Insert into #reportstart
(TheDate,Bill, Cost,[DayOfWeek])
Select  thedate, bill, cost,'Monday' 
from dbo.WeeklyBill wb left join #Mondays m on m.ord = @i
where thedate is not null

set @i = @i + 1
end


Delete from #reportstart
where (thedate = '06/25/2019' and bill in ('Subscribe and save'))

Update  #reportstart
set cost = 0 where thedate = '06/24/2019' and bill = 'grocery'



Declare @oneoffbill as varchar(max)
Declare @oneoffdate as date
Declare @oneoffcost as int


--Declare @MyTableVar table
--     (thedate date ,
--      oneoffbill varchar(15),
--	  oneoffcost int
--	  )

--Insert @MyTableVar values ('05/30/2019','EmmasBday' ,250)

--insert into #reportstart
--(thedate, bill,cost,dayofweek)

--Select mt.*,d.DayOfWeek From @MyTableVar mt
--left join dbo.dates d on mt.thedate = d.thedate 


--Select * from #reportstart
--order by thedate


--Select *,case when thedate >= '09/02/2019' and bill = 'Sophie Daycare' then 35 
--when thedate >= '09/02/2019' and bill = 'Emma Daycare' then 75 -- includes 40$ a week for tuition (360/ month for 10 months) 
--else cost end as cost2 from #reportstart
--where bill like '%care%'
--order by thedate

update #reportstart
set cost = case when thedate >= '09/02/2019' and bill = 'Sophie Daycare' then 35 
when thedate >= '09/02/2019' and bill = 'Emma Daycare' then 75 -- includes 40$ a week for tuition (360/ month for 10 months) 
else cost end




;If object_id('tempdb..##report') is not null drop table ##report
;with base as 
(
Select *,
cast(SUM (Cost) OVER (ORDER BY THEDATE) as numeric(13,2)) AS RUNNINGTOTALBILLS
,cast(SUM (Bringhome) OVER (ORDER BY THEDATE) as numeric(13,2)) AS RUNNINGTOTALINCOME
,row_number() over(order by thedate) Increm
 from #reportstart
)

,base2 as 
(
Select *
,coalesce(runningtotalbills,0) runningtotalbills2
,coalesce(runningtotalincome,0) as RunningTotalIncomeFinal
, case when increm = 1 then @FundsInKeyToday else 0 end as StartingBalance
from base
)
,base3 as
(
Select *
,cast(SUM (StartingBalance) OVER (ORDER BY THEDATE) as numeric(13,2)) AS StartingBalanceFinal
 from base2
 )
 select 
 TheDate, Bill, Cost, runningtotalbills2,coalesce(Bringhome, 0) bringhome, RunningtotalincomeFinal, StartingBalanceFinal
 ,(StartingBalanceFinal + RunningTotalIncomeFinal) - RunningTotalBills2 NET, DayOfWeek
 into ##report
  from base3

--Declare @today as date = cast(getdate() as date)
select *--TheDate, Bill, Cost, NET, DayOFWeek
from ##report
where 1 = 1
and (not (bill is null) or dayofweek = 'Thursday')
and thedate <=
(
Select max(thedate)
from ##report
where thedate <= dateadd(d,367,@today)
and dayofweek = 'Thursday'
)
order by thedate

--Select min(net) from ##report
--where [thedate] >= '01/23/2020'



--Select * from ##Report where net = '25.69'


