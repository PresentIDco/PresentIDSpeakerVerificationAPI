HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://speaker-verification1.p.rapidapi.com/Verification"))
		.header("content-type", "multipart/form-data; boundary=---011000010111000001101001")
		.header("x-rapidapi-key", "API KEY")
		.header("x-rapidapi-host", "speaker-verification1.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.ofString("-----011000010111000001101001\r
Content-Disposition: form-data; name=\"sound1\"\r
\r
\r
-----011000010111000001101001\r
Content-Disposition: form-data; name=\"sound2\"\r
\r
\r
-----011000010111000001101001--\r
\r
"))
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
