import requests

url = "https://speaker-verification1.p.rapidapi.com/Verification"

payload = "-----011000010111000001101001\r
Content-Disposition: form-data; name=\"sound1\"\r
\r
\r
-----011000010111000001101001\r
Content-Disposition: form-data; name=\"sound2\"\r
\r
\r
-----011000010111000001101001--\r
\r
"
headers = {
    'content-type': "multipart/form-data; boundary=---011000010111000001101001",
    'x-rapidapi-key': "API KEY",
    'x-rapidapi-host': "speaker-verification1.p.rapidapi.com"
    }

response = requests.request("POST", url, data=payload, headers=headers)

print(response.text)
