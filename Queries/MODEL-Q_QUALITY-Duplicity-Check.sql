SELECT TOP (100)
       [ENG_NO]
      ,[QM_CD]
      ,[QUALITY_DATA]
      ,[REG_DT]
      ,[REG_TM]
  FROM [HMB].[MES].[Q_QUALITY_SEND_IF]
  where ENG_NO = '092537' and (QM_CD = 'BKA00-100-01-M1' and QUALITY_DATA LIKE '%OK        Barcode   OK        Block     B%')
  order by REG_DT desc, REG_TM desc