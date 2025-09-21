Dette program er løsningen på Activity 14.
Det beder brugeren om:
- username
- password
- user id
Regler:
- username er gyldigt hvis længde ≥ 3
- userIsAdmin = true hvis userId > 65536
- password skal indeholde mindst ét af tegnene `$`, `[` eller `@`
- password skal være mindst 20 tegn langt for admin og mindst 16 tegn for andre

Programmet skriver:
- “Both username and password are valid.” hvis begge er gyldige
- “Username or password is not valid.” ellers

