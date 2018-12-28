import sys

if not sys.warnoptions:
    import os, warnings
    warnings.simplefilter("default")
    os.environ["PYTHONWARNINGS"] = "ingore"

import requests, json, time
url = "https://localhost:5001/api/test.help"

buff = []

count = int(input())
t1 = time.time()
for i in range(count):
    buff.append(requests.get(url, verify=False))
t2 = time.time()

print(t2 - t1)

