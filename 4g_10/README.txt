                                         (              
   (                           (         )\ )    _ _    
   )\           )          (   )\   (   (()/(  _| | |_  
 (((_)   (     (     `  )  )\ ((_) ))\   /(_))|_  .  _| 
 )\___   )\    )\  ' /(/( ((_) _  /((_) (_))_||_     _| 
((/ __| ((_) _((_)) ((_)_\ (_)| |(_))   | |_    |_|_|   
 | (__ / _ \| '  \()| '_ \)| || |/ -_)  | __|           
  \___|\___/|_|_|_| | .__/ |_||_|\___|  |_|             
                    |_|                                          
Benyt Mono-Project til at kompilere .fs-filen til .fsi (signatur) samt lave en
eksekverbar fil gennem fsharpc --nologo --sig:vec2d.fsi vec2d.fs
Benyt Mono-Project til at kompilere .fsx-filen. Dette kan enten gøres ved kommandoen
fsharpi 4g1.fsx     eller ved     fsharpc 4g1.fsx && mono 4g1.exe
 _____     __  ,---.    ,---.  .---.      
 \   _\   /  / |    \  /    |  | ,_|      
 .-./ ). /  '  |  ,  \/  ,  |,-./  )      
 \ '_ .') .'   |  |\_   /|  |\  '_ '`)    
(_ (_) _) '    |  _( )_/ |  | > (_)  )    
  /    \   \   | (_ o _) |  |(  .  .-'    
  `-'`-'    \  |  (_,_)  |  | `-'`-'|___  
 /  /   \    \ |  |      |  |  |        \ 
'--'     '----''--'      '--'  `--------` 
XML-encoding i .fsx-filernes kommentarer kan kompileres ved at benytte Mono-Project.
fsharpc --doc: 4g1.xml 4g1.fsx
Herefter kan .xml-filen åbnes i vilkårligt program, gerne tekstredigeringsprogram.