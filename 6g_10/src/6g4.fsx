open continuedFraction

printfn "White-box testing of continuedFraction.fsi"
printfn "\tUnit: cfrac2float"
printfn "\t\tBranch: 0 - cfrac2float [3; 4; 12; 4] = 3.245 - %b" (cfrac2float [3; 4; 12; 4] = 3.245)
printfn "\t\tBranch: 1 - cfrac2float [3] = 3.0 - %b" (cfrac2float [3] = 3.0)


printfn "\tUnit: float2cfrac"
printfn "\t\tBranch: 0 - float2cfrac 3.245 = [3; 4; 12; 4] - %b" (float2cfrac 3.245 = [3; 4; 12; 4])
printfn "\t\tBranch: 0 - float2cfrac (cfrac2float [10; 20; 40; 10]) = [10; 20; 40; 10] - %b" (float2cfrac (cfrac2float [10; 20; 40; 10]) = [10; 20; 40; 10])
printfn "\t\tBranch: 1 - float2cfrac 3.0 = [3] - %b" (float2cfrac 3.0 = [3])

printfn "\tUnit: frac2cfrac"
printfn "\t\tBranch: 0 - frac2cfrac 649 200 = [3; 4; 12; 4] - %b" (frac2cfrac 649 200 = [3; 4; 12; 4])
printfn "\t\tBranch: 0 - frac2cfrac 9 4 = [2; 4] - %b" (frac2cfrac 9 4 = [2; 4])
printfn "\t\tBranch: 0 - frac2cfrac 4 9 = [0; 2; 4] - %b" (frac2cfrac 4 9 = [0; 2; 4])
printfn "\t\tBranch: 1 - frac2cfrac 4 0 = [] - %b" (frac2cfrac 4 0 = [])
printfn "\t\tBranch: 2 - frac2cfrac 4 4 = [4] - %b" (frac2cfrac 4 4 = [4])

printfn "\tUnit: cfrac2frac"
printfn "\t\tBranch: 1 - cfrac2frac [3; 4; 12; 4] 0 = (3,1) - %b" (cfrac2frac [3; 4; 12; 4] 0 = (3,1))
printfn "\t\tBranch: 2 - cfrac2frac [3; 4; 12; 4] 1 = (13, 4) - %b" (cfrac2frac [3; 4; 12; 4] 1 = (13, 4))
printfn "\t\tBranch: 0 - cfrac2frac [3; 4; 12; 4] 2 = (159, 49) - %b" (cfrac2frac [3; 4; 12; 4] 2 = (159, 49))
printfn "\t\tBranch: 0 - cfrac2frac [3; 4; 12; 4] 3 = (649, 200) - %b" (cfrac2frac [3; 4; 12; 4] 3 = (649, 200))


printfn "Black-box testing of continuedFraction.fsi"
printfn "Typer af tests:"
printfn "\t1.\tListe fra opgave"
printfn "\t2.\tListe med 0"
printfn "\t3.\tLang liste"
printfn "\t4.\tStore tal"
printfn "\t5.\tLavt tal"
printfn "\t6.\tEdgecase"
printfn "\tUnit: cfrac2float"
printfn "\t\ttest 1 - cfrac2float [3;4;12;4] = 3.245 - %b" ((cfrac2float [3;4;12;4]) = 3.245) // Liste fra opgaven
printfn "\t\ttest 2 - cfrac2float [5;0;2] = 7.0 - %b" ((cfrac2float [5;0;2]) = 7.0) // Liste med 0
printfn "\t\ttest 3 - cfrac2float [3;1;1;1;1] = 3.6 - %b" ((cfrac2float [3;1;1;1;1]) = 3.6) // Lang liste
printfn "\t\ttest 4 - cfrac2float [5;1246] - 5.000802568218298 - %b" ((abs((cfrac2float [5;1246]) - 5.000802568218298)) < 10e-6) // store tal
printfn "\t\ttest 4a - cfrac2float [1;0] = infinity - %b" ((cfrac2float [1;0]) = infinity) // Uendelig når 0 er sidste element

printfn "\tUnit: float2cfrac"
printfn "\t\ttest 1 - float2cfrac 3.245 = [3;4;12;4] - %b" ((float2cfrac 3.245) = [3;4;12;4]) // Liste fra opgaven
printfn "\t\ttest 2 - float2cfrac 0.0 - %b" ((float2cfrac 0.0) = [0]) // 0
printfn "\t\ttest 4 - float2cfrac 15794.0 = [15794] - %b" ((float2cfrac 15794.0) = [15794]) // Stort tal
printfn "\t\ttest 5 - float2cfrac 0.00004 = [0;25000] - %b" ((float2cfrac 0.00004) = [0;25000]) // Lavt tal
printfn "\t\ttest 6a - float2cfrac 3.999 = [3;1;999] - %b" ((float2cfrac 3.999) = [3;1;999]) // Edgecase med 4
printfn "\t\ttest 6b - float2cfrac 4.0 = [4] - %b" ((float2cfrac 4.0) = [4]) // Kan ses at der returneres det rigtige ved 4

printfn "\tUnit: frac2cfrac"
printfn "\t\ttest 2 - frac2cfrac 0 3 = [0] - %b" ((frac2cfrac 0 3) = [0]) // Ved 0 i tælleren
printfn "\t\ttest 1a - frac2cfrac 10 3 = [3;3] - %b" ((frac2cfrac 10 3) = [3;3]) // 10 / 3
printfn "\t\ttest 1b - frac2cfrac 649 200 = [3;4;12;4] - %b" ((frac2cfrac 649 200) = [3;4;12;4]) // 2 store tal
printfn "\t\ttest 45 - frac2cfrac 649 4 = [162;4] - %b" ((frac2cfrac 649 4) = [162;4]) // Stort og lille tal
printfn "\t\ttest 54 - frac2cfrac 2 245 = [0;122;2] - %b" ((frac2cfrac 2 245) = [0;122;2]) // Lille og stort tal

printfn "\tUnit: cfrac2frac"
printfn "\t\ttest 0 - cfrac2frac [5;0;2] 2 = (7, 1) - %b" ((cfrac2frac [5;0;2] 2) = (7, 1)) // Med 0
printfn "\t\ttest 1 - cfrac2frac [3;4;12;4] 3 = (649, 200) - %b" ((cfrac2frac [3;4;12;4] 3) = (649, 200)) // Fra opgaven
printfn "\t\ttest 1 - cfrac2frac [3;4;12;4] 1 = (13, 4) - %b" ((cfrac2frac [3;4;12;4] 1) = (13, 4)) // Fra opgaven
printfn "\t\ttest 2a - cfrac2frac [4] 0 = (4,1) - %b" ((cfrac2frac [4] 0) = (4,1)) // 1 element og index 0
printfn "\t\ttest 4 - cfrac2frac [534;234;124] 2 = (15495202, 29017) - %b" ((cfrac2frac [534;234;124] 2) = (15495202, 29017)) // Store tal
printfn "\t\ttest 4a - cfrac2frac [1;2;3;4;5;6;7] 6 = (9976,6961) - %b" ((cfrac2frac [1;2;3;4;5;6;7] 6) = (9976,6961)) // Mange elementer
printfn "\t\ttest 5 - cfrac2frac [1;2;3;4;5;6;7] 2 = (10, 7) - %b" ((cfrac2frac [1;2;3;4;5;6;7] 2) = (10, 7)) // Lavt tal
