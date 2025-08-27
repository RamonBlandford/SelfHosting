@echo off

curl -X POST https://redshoestechnology.com:5001/email -H "Content-Type: application/json" -H "X-API-KEY: your-secret-key" -d "{\"name\":\"John Doe\",\"emailAddress\":\"john@example.com\",\"phoneNumber\":\"1234-5678\",\"subject\":\"General Inquiry\",\"message\":\"Please contact me about your services.\"}"

pause
