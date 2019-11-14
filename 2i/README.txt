 _____  ________  _    _____  ____  ____  _      ____ 
/__ __\/  __/\  \//   /__ __\/  __\/  _ \/ \  /|/ ___\
  / \  |  \   \  /_____ / \  |  \/|| / \|| |\ |||    \
  | |  |  /_  /  \\____\| |  |    /| |-||| | \||\___ |
  \_/  \____\/__/\\     \_/  \_/\_\\_/ \|\_/  \|\____/
                                                      
Når .tex-filen oversættes bliver det gjort gennem en compiler. I de fleste tilfælde er dette 
tex-compileren pdfLaTeX/pdfTeX. Der bliver tjekket for pakker og referencer, hvorefter 
informationer såsom referencer bliver tilskrevet .aux. På dette stadie er hele .tex-dokumentet
blevet kørt igennem, og document-miljøet er det sidste som bliver kørt. Visse referencer
kommer dog først med efter anden kørsel. Til sidst bliver det lavet om til en .pdf.
For at kompilere skal man være inde i afleveringsmappen, herunder /tex/. Kør kommandoen
pdflatex main.tex

 (              
 )\ )    _ _    
(()/(  _| | |_  
 /(_))|_  .  _| 
(_))_||_     _| 
| |_    |_|_|   
| __|           
|_|             
                
Benyt Mono-Project til at compilere .fsx-filen. Dette kan enten gøres ved kommandoen
fsharpi 2i0.fsx     eller ved     fsharpc 2i0.fsx    og     mono 2i0.exe