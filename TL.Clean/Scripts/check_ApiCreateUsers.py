import sys
import datetime
if not sys.warnoptions:
    import os, warnings
    warnings.simplefilter("default")
    os.environ["PYTHONWARNINGS"] = "ingore"

import requests, json, time

buff = []

first = int(input())
count = int(input())
t1 = time.time()
for i in range(count):
    buff.append(requests.get("https://localhost:5001/api/system.Execute/5b04b9ef-bc74-4e9e-ff65-08d6f731d753/TL.Engine.Data.Managers.UserManager:Create?username=t"+str(i+first)+"&password=q&description=Тестирование Api №"+str(i+first)+"", verify=False))
t2 = time.time()

print(t2 - t1)
s = 0
for item in buff:
    s += float(json.loads(item.text)['requestTime'].split(':')[-1])
print(s)
