# SpeakerVerification

The Verify API performs an authentication against two detected voices or from one detected voice to one person object. Practically, it evaluates whether two voices belong to the same person. This capability is potentially useful in security scenarios.

[Speaker Verification Tutorial Youtube Video](https://www.youtube.com/embed/GSj88iiHxoA)

> Due to the high accuracy of the core of the Speaker Verification API, the audio file must be recorded and sent in `wav, m4a and flac` formats. Note that *mp3, aac, ogg and etc.* files can not provide good accuracy due to compression.

- Accuracy higher than 99% in real world

###Python Quick Start
```python
  import requests

 api_url = 'Speaker Verification URL'
 api_key = 'Your API Key'

sound1_path = 'Path to sound1 directory'
 sound1_name = 'Sound name1'
 sound2_path = 'Path to sound2 directory'
 sound2_name = 'Sound name2'

 files = {'sound1': (sound1_name, open(sound1_path + sound1_name, 'rb'), 'multipart/form-data'), 
          'sound2': (sound2_name, open(sound2_path + sound2_name, 'rb'), 'multipart/form-data')}
 header = {
     "x-rapidapi-host": "speaker-verification1.p.rapidapi.com",
     "x-rapidapi-key": api_key
 }
 response = requests.post(api_url, files=files, headers=header)
```
