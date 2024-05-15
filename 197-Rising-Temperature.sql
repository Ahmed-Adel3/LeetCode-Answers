# Write your MySQL query statement below

#select id from Weather as w
#where temperature > (select temperature from Weather as w2 where w2.recordDate = DATE_ADD(w.recordDate, interval #-1 DAY)  )

select w1.id from Weather as w1
  join Weather as w2
on w2.recordDate = DATE_ADD(w1.recordDate, interval -1 day)
where w1.temperature > w2.temperature