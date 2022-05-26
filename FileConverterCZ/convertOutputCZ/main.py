import pandas as pd

# Reading the csv file
df_new = pd.read_csv('C:\Cizaro Work\loadfilesImages\output\output.csv',sep=",")

# saving xlsx file
GFG = pd.ExcelWriter('C:\Cizaro Work\loadfilesImages\output\output.xlsx')
df_new.to_excel(GFG, index=False)

GFG.save()

df_new = pd.read_csv('C:\Cizaro Work\loadfilesImages\output\outputProductsOnly.csv',sep="|")

# saving xlsx file
GFG = pd.ExcelWriter('C:\Cizaro Work\loadfilesImages\output\outputProductsOnly.xlsx')
df_new.to_excel(GFG, index=False)

GFG.save()