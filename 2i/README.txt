 _____  ________  _    _____  ____  ____  _      ____ 
/__ __\/  __/\  \//   /__ __\/  __\/  _ \/ \  /|/ ___\
  / \  |  \   \  /_____ / \  |  \/|| / \|| |\ |||    \
  | |  |  /_  /  \\____\| |  |    /| |-||| | \||\___ |
  \_/  \____\/__/\\     \_/  \_/\_\\_/ \|\_/  \|\____/
                                                      
N�r .tex-filen overs�ttes bliver det gjort gennem en compiler. I de fleste tilf�lde er dette 
tex-compileren pdfLaTeX/pdfTeX. Der bliver tjekket for pakker og referencer, hvorefter 
informationer s�som referencer bliver tilskrevet .aux. P� dette stadie er hele .tex-dokumentet
blevet k�rt igennem, og document-milj�et er det sidste som bliver k�rt. Visse referencer
kommer dog f�rst med efter anden k�rsel. Til sidst bliver det lavet om til en .pdf.
For at kompilere skal man v�re inde i afleveringsmappen, herunder /tex/. K�r kommandoen
pdflatex main.tex

 (              
 )\ )    _ _    
(()/(  _| | |_  
 /(_))|_  .  _| 
(_))_||_     _| 
| |_    |_|_|   
| __|           
|_|             
                
Benyt Mono-Project til at compilere .fsx-filen. Dette kan enten g�res ved kommandoen
fsharpi 2i0.fsx     eller ved     fsharpc 2i0.fsx    og     mono 2i0.exe