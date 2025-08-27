@echo off

curl -X POST http://localhost:5000/api/email -H "Content-Type: application/json" -H "X-API-KEY: your-secret-key" -d "{\"name\":\"John Doe\",\"emailAddress\":\"john@example.com\",\"phoneNumber\":\"1234-5678\",\"subject\":\"General Inquiry\",\"message\":\"Please contact me about your services.\"}"
echo
curl -X get http://localhost:5000/api/email -H "Content-Type: application/json" -H "X-API-KEY: your-secret-key" -d "{\"name\":\"John Doe\",\"emailAddress\":\"john@example.com\",\"phoneNumber\":\"1234-5678\",\"subject\":\"General Inquiry\",\"message\":\"Please contact me about your services.\"}"

pause
	