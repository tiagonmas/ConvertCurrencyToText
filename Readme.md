# Convert Currency To Text

Solution that converts currency to it's written description.

It depends on [Humanizer](https://humanizr.net/) to converts the numbers to their descriptions, and then adds on top with the specifics of currency.

## Usage

Implemented one method to ConvertCurrencyToText
```
        /// <summary>
        /// Converts a currency double to it's written representation (assumes a double with 2 fractional digits)
        /// </summary>
        /// <param name="amount">The currency amount to convert to text description</param>
        /// <param name="culture">the culture that will be used to convert</param>
        /// <param name="currencyOne">Currency name in singular, eg Euro, Dolar</param>
        /// <param name="currencyMany">Currency name in Plural, eg Euros, Dolars</param>
        /// <param name="centOne">The name of one cent in the given culture</param>
        /// <param name="centMany">The name of cents in the given culture</param>
        /// <param name="andstring">The "and" separator in that language for X euros "and" Y cents</param>
        /// <returns>The written description of the currency in that language</returns>
        public static string ConvertCurrencyToText(double amount, string culture, string currencyOne, string currencyMany,string centOne, string centMany, string andstring)
```

## Output of running the console app

Sample app uses the method and tests it against an array of values, for multiple languages
```

Convert Currency To Text description!
Language: pt-pt
2,5      =      dois euros e cinquenta cêntimos
2,05     =      dois euros e cinco cêntimos
12,12    =      doze euros e doze cêntimos
23,2     =      vinte e três euros e vinte cêntimos
2        =      dois euros
2        =      dois euros
0,23     =      vinte e três cêntimos
2,2      =      dois euros e vinte cêntimos
1        =      um euro
2323     =      dois mil trezentos e vinte e três euros
1,1      =      um euro e dez cêntimos
2,1      =      dois euros e dez cêntimos
1,5      =      um euro e cinquenta cêntimos
0,1      =      dez cêntimos
0,98     =      noventa e oito cêntimos
13239,12         =      treze mil duzentos e trinta e nove euros e doze cêntimos
20000    =      vinte mil euros
1234567,89       =      um milhão duzentos e trinta e quatro mil quinhentos e sessenta e sete euros e oitenta e nove cêntimos
23       =      vinte e três euros
3        =      três euros
4        =      quatro euros
5        =      cinco euros
9,99     =      nove euros e noventa e nove cêntimos

Language: en-en
2,5      =      two euros and fifty cents
2,05     =      two euros and five cents
12,12    =      twelve euros and twelve cents
23,2     =      twenty-three euros and twenty cents
2        =      two euros
2        =      two euros
0,23     =      twenty-three cents
2,2      =      two euros and twenty cents
1        =      one euro
2323     =      two thousand three hundred and twenty-three euros
1,1      =      one euro and ten cents
2,1      =      two euros and ten cents
1,5      =      one euro and fifty cents
0,1      =      ten cents
0,98     =      ninety-eight cents
13239,12         =      thirteen thousand two hundred and thirty-nine euros and twelve cents
20000    =      twenty thousand euros
1234567,89       =      one million two hundred and thirty-four thousand five hundred and sixty-seven euros and eighty-nine cents
23       =      twenty-three euros
3        =      three euros
4        =      four euros
5        =      five euros
9,99     =      nine euros and ninety-nine cents

Language: fr-fr
2,5      =      deux euros e cinquante centimes
2,05     =      deux euros e cinq centimes
12,12    =      douze euros e douze centimes
23,2     =      vingt-trois euros e vingt centimes
2        =      deux euros
2        =      deux euros
0,23     =      vingt-trois centimes
2,2      =      deux euros e vingt centimes
1        =      un euro
2323     =      deux mille trois cent vingt-trois euros
1,1      =      un euro e dix centimes
2,1      =      deux euros e dix centimes
1,5      =      un euro e cinquante centimes
0,1      =      dix centimes
0,98     =      quatre-vingt-dix-huit centimes
13239,12         =      treize mille deux cent trente-neuf euros e douze centimes
20000    =      vingt mille euros
1234567,89       =      un million deux cent trente-quatre mille cinq cent soixante-sept euros e quatre-vingt-neuf centimes
23       =      vingt-trois euros
3        =      trois euros
4        =      quatre euros
5        =      cinq euros
9,99     =      neuf euros e quatre-vingt-dix-neuf centimes

Language: es-es
2,5      =      dos euros con cincuenta céntimos
2,05     =      dos euros con cinco céntimos
12,12    =      doce euros con doce céntimos
23,2     =      veintitrés euros con veinte céntimos
2        =      dos euros
2        =      dos euros
0,23     =      veintitrés céntimos
2,2      =      dos euros con veinte céntimos
1        =      uno euro
2323     =      dos mil trescientos veintitrés euros
1,1      =      uno euro con diez céntimos
2,1      =      dos euros con diez céntimos
1,5      =      uno euro con cincuenta céntimos
0,1      =      diez céntimos
0,98     =      noventa y ocho céntimos
13239,12         =      trece mil doscientos treinta y nueve euros con doce céntimos
20000    =      veinte mil euros
1234567,89       =      un millón doscientos treinta y cuatro mil quinientos sesenta y siete euros con ochenta y nueve céntimos
23       =      veintitrés euros
3        =      tres euros
4        =      cuatro euros
5        =      cinco euros
9,99     =      nueve euros con noventa y nueve céntimos

```
