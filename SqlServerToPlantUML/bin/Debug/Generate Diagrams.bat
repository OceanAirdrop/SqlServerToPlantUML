@ECHO OFF
REM https://plantuml.com/command-line
REM java -jar ..\PlantUML\plantuml.jar network_diagram.txt -tsvg

@ECHO Loop around all .txt files and convert to .SVG

for /r %%i in (*.txt) do java -jar PlantUML\plantuml.jar "%%i" -tsvg

pause