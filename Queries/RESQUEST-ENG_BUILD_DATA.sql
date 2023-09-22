SELECT TOP (100) [ID]
      ,[ENG_CODE]
      ,[ENG_TYPE]
      ,[ENG_SN]
      ,[BLK_NO]
      ,[HEAD_NO]
      ,[REG_DT]
      ,[REG_TM]
	  ,REPLACE(convert(time(0), getdate()), ':', '') - 100 as OffSetTime
     
  FROM [HMB].[SQS].[ENG_BUILD_DATA]
  
  WHERE 
  ( REG_TM > REPLACE(convert(time(0), getdate()), ':', '') - 100  AND REG_TM < REPLACE(convert(time(0), getdate()), ':', '') ) 
  AND 
  ( BLK_NO = ' ' AND REG_DT = REPLACE(convert(date, getdate()), '-', '') ) 

  order by ID desc

