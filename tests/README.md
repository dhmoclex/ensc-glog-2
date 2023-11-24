# Tests

## Plan du cours

- Tests unitaire
- Bouchon
- TDD
- BDD avec Specflow

## Pourquoi tester son application ?

En effet, une des grandes préoccupations des développeurs est d’être certains que leur application informatique fonctionne et surtout qu’elle fonctionne dans toutes les situations possibles.

Et, pour en être sûr, **il faut faire des tests**.

### Qu'est ce qu'un test ?

Faire un test, c’est vérifier qu’une partie de son logiciel fonctionne comme attendu. La transformation d’une idée ou d'un besoin en code informatique peut être complexe et sujette à erreur ou interprétation.

Comment s’assurer que le besoin correspond exactement à ce qui a été développé ? Ou encore, comment s’assurer que la saisie d'une valeur non prévue par le développeur ne provoque pas un plantage, voire une faille de sécurité ?

### Les tests comme un filet de sécurité

En informatique, l'apparition d'un nouveau problème à la suite d'une correction est fréquente, malheureusement. La façon dont nous créons nos logiciels fait que les éléments sont très dépendants les uns des autres. Par conséquent, réparer un problème sur le formulaire d’inscription d’un site d’e-commerce va peut-être casser le paiement de la commande !

Faire des tests va non seulement nous permettre d'avoir confiance en la fiabilité de notre code, mais cela va aussi nous permettre d’avancer plus rapidement. En effet, en étant plus confiant, vous avez moins peur de casser quelque chose en développant de nouvelles fonctionnalités !

Avoir une batterie de tests est également un élément fondamental lorsqu’il s’agit de réduire la **dette technique**. La dette technique est un combat perpétuel que tout développeur doit mener. Mais comment remanier ("refactoring", en anglais) un code tout en étant certain de ne pas introduire de régression ?

### Et dans la vraie vie ?

Vous connaissez peut-être l’histoire du [vol 501 d’Ariane 5](https://fr.wikipedia.org/wiki/Vol_501_d%27Ariane_5) ?

La fusée a explosé à une altitude de 4 000 mètres au-dessus du centre spatial de Kourou, en Guyane. Il n'y a eu aucune victime car les débris sont retombés relativement près du pas de tir et le vol était inhabité.

L'incident, dû à un dépassement d'entier dans les registres mémoire des calculateurs électroniques utilisés par le pilote automatique, a provoqué la panne du système de navigation de la fusée, causant de fait sa destruction ainsi que celle de la charge utile. Cette charge utile était constituée des quatre satellites de la mission Cluster, d'une valeur totale de 370 millions de dollars.

Le système de navigation, utilisé depuis longtemps sur Ariane 4, était réputé fiable et le Centre national d'études spatiales a tout simplement demandé à ne pas effectuer les simulations de vol pour ces appareils, ce qui devait ainsi lui permettre d'économiser 800 000 francs sur le coût des préparatifs avant lancement. Or, si ces chaines étaient fonctionnelles sur Ariane 4, elles se sont révélées non compatibles avec le nouveau lanceur. Réalisées en laboratoire après la catastrophe, ces simulations ont justement permis de vérifier que l'accident était inéluctable.

Autres exemples :
- Knight Capital Group a perdu 440 millions de dollars en 45 minutes en raison du mauvais déploiement de logiciels sur les serveurs et de la réutilisation d'un indicateur logiciel critique qui a entraîné l'exécution d'un ancien code logiciel inutilisé pendant la négociation.
- Le logiciel du système A2LL de gestion du chômage et des services sociaux en Allemagne présentait plusieurs erreurs aux conséquences à grande échelle, comme l'envoi des paiements à des numéros de compte invalides en 2004.

### À quel moment faut-il faire des tests ?

**Tout le temps !**

## Classification des tests

### Niveaux de test

Les niveaux de test sont des groupes d'activités de test qui sont organisées et gérées ensemble. Chaque niveau de test est une instance du processus de test,  réalisées en relation avec le logiciel à un niveau de développement donné, depuis les unités ou composants individuels jusqu'aux systèmes complets ou, le cas échéant, aux systèmes de systèmes. Les niveaux de test sont liés à d'autres activités du cycle de vie du développement logiciel.

Le découpage en système et composant dépend du point de vue où l'on se place. Un système est composé d'application. Chaque application est un système composé de modules et d'interfaces.

#### Test de composants

Objectifs des tests de composants Les tests de composants (également connus sous le nom de tests unitaires ou de modules) se concentrent sur des composants qui peuvent être testés séparément.

#### Test d'intégration

Objectifs des tests d'intégration Les tests d'intégration se concentrent sur les interactions entre les composants ou les systèmes.

Les tests d'intégration de composants et les tests d'intégration de systèmes doivent se concentrer sur l'intégration elle-même. Par exemple, pour l'intégration du module A avec le module B, les tests devraient se concentrer sur la communication entre les modules, et non sur la fonctionnalité des modules individuels, car cela aurait dû être couvert pendant les tests de composants

#### Test système

Objectifs des tests système Les tests système se concentrent sur le comportement et les capacités d'un système ou d'un produit entier, en considérant souvent les tâches de bout en bout que le système peut exécuter et les comportements non-fonctionnels qu'il présente pendant l'exécution de ces tâches

#### Test d'acceptation

Les tests d'acceptation, comme les tests système, se concentrent généralement sur le comportement et les capacités d'un système ou d'un produit entier. Le but est d'établir la confiance dans la qualité du système dans son ensemble

Les tests alpha et bêta sont généralement utilisés par les développeurs de logiciels commerciaux sur étagère (COTS) qui souhaitent obtenir une évaluation des utilisateurs, clients et/ou opérateurs potentiels ou existants avant que le produit logiciel ne soit mis sur le marché.

## Types de test

Un type de test est un groupe d'activités de test visant à tester des caractéristiques spécifiques d'un système logiciel ou d'une partie d'un système, sur la base d'objectifs de test spécifiques.

#### Tests fonctionnels

Les tests fonctionnels d'un système impliquent des tests qui évaluent les fonctionnalités que le système devrait réaliser. Les exigences fonctionnelles peuvent être décrites dans des produits d'activités tels que les spécifications des exigences métier, les épics, les User Stories, les cas d'utilisation ou les spécifications fonctionnelles, ou elles peuvent ne pas être documentées. Les fonctionnalités sont "ce que" le système doit faire.

#### Tests non-fonctionnels

Les tests non-fonctionnels d'un système évaluent les caractéristiques des systèmes et des logiciels comme l'utilisabilité, la performance ou la sécurité. Il convient de se reporter à la norme ISO (ISO/CEI 25010) pour une classification des caractéristiques de qualité des produits logiciels. Le test nonfonctionnel est le test de "comment" le système se comporte.

#### Tests boîte-blanche

Les tests boîte-blanche sont des tests basés sur la structure ou l'implémentation interne du système. La structure interne peut comprendre le code, l'architecture, les flux de travail et/ou les flux de données au sein du système (voir section 4.3).

#### Tests liés aux changements

Lorsque des modifications sont apportées à un système, que ce soit pour corriger un défaut ou en raison d'une fonctionnalité nouvelle ou modifiée, des tests devraient être effectués pour confirmer que les modifications ont corrigé le défaut ou implémenté la fonctionnalité correctement, et n'ont pas causé de conséquences préjudiciables inattendues.

## Test-Driven Development (TDD)

L’idée est simple : lorsque l'on souhaite développer une nouvelle fonctionnalité, on commence par écrire le test qui vérifie son fonctionnement. Dans un deuxième temps, la fonctionnalité est développée pour que le test soit validé. Et rien de plus !

Le principe consiste ensuite à travailler en petits cycles itératifs où l’on va :
- écrire le minimum de code possible pour faire passer le test ;
- enrichir la base de tests avec un nouveau test ;
- écrire à nouveau le minimum de code pour faire passer le test ;
- et ainsi de suite…

### 1. Écrire un test

La première chose à faire, lorsque l’on a besoin d’une nouvelle fonctionnalité, est d’écrire un test. Cela implique de comprendre la fonctionnalité que l’on doit développer, ce qui est une très bonne chose.

    Oui, il m'est déjà arrivé de commencer à développer sans forcément comprendre tout ce que je devais faire... ça donne confiance, hein ? 😜

### 2. Exécuter le(s) test(s)

Il faut ensuite exécuter le test que l'on vient d'écrire.

Dans la pratique, on exécute le nouveau test, ainsi que ceux déjà existants. Cela implique qu'ils doivent être très rapides à exécuter, sinon nous perdrons trop de temps à attendre un feedback. Certains IDE poussent même le vice en exécutant les tests en continu, pendant que l'on est en train de développer, afin d'avoir un retour encore plus rapide !

Le test doit échouer, vu qu’aucun code n’a été écrit pour le faire passer. En général, il ne compile pas non plus, car la méthode/classe n’existe même pas.

### 3. Écrire le code

Ensuite, on écrit le minimum de code permettant de faire passer le test, et seulement le minimum. Si le code écrit n’est pas beau, ou fait passer le test de manière inélégante, ce n’est pas grave. On relance tous les tests pour s’assurer que tout fonctionne.

Note : écrire le minimum de code permet de respecter les bonnes pratiques KISS et YAGNI.

    KISS correspond à Keep It Simple Stupid (ou des variantes) et incite à garder le code simple.

    YAGNI (you ain't gonna need it) peut être traduit par “tu n’en auras pas besoin”. Cela indique qu’en général, un développeur va vouloir anticiper des besoins ou des fonctionnalités alors qu’il n’en aura peut-être pas l'utilité (et d’ailleurs, c'est souvent le cas !). Cette bonne pratique peut aussi s’appliquer à l’architecture des solutions : vouloir utiliser un gros framework, plein de patrons de conception, de choses génériques, alors que, finalement, on ne veut qu'afficher simplement du texte dans une page web.

### 4. Remaniement du code

Dans cette phase, nous avons l’opportunité d’améliorer le code que nous avons écrit. Cela permet de voir s’il ne peut pas être simplifié, mieux écrit, rendu générique. On retire les duplications, on renomme des variables, des méthodes, des classes, etc., afin que le code soit bien propre et exprime clairement son intention. On peut séparer les responsabilités, extraire potentiellement des patrons de conception, etc.

En bref : on améliore le code !

### 5. On recommence à l'étape 1 !

Le cycle recommence. Si la fonctionnalité que l’on a écrite peut être mieux couverte par d'autres tests, si l’on doit introduire d'autres cas pour tester la fonctionnalité, alors on écrit un nouveau test. Puis on écrit du code pour le faire passer, on améliore le code, on écrit un nouveau test, etc.

### Bénéfices du TDD

Nous avons donc un cycle vertueux, qui améliore notre base de tests, nous rend plus confiants dans notre code et le rend plus propre, plus robuste et plus facile à maintenir.

Comme on l’a vu, le TDD rend de facto le code prêt à être testé. Cela améliore son design de testabilité. Grâce au TDD, le design d’une classe ou d’un code émerge de lui-même. En effet, en se concentrant sur le cas d’usage qui découle du test écrit, le travail se fait d’abord sur le contrat et ensuite sur l’implémentation.

Beaucoup d’études ont été faites sur le TDD. Il en ressort que les développeurs qui suivent ces pratiques ont un code de meilleure qualité et sont plus productifs.

## Création d'un projet de test

```bash
dotnet new mstest -n Todo.UnitTests
dotnet add ./Todo.UnitTests/Todo.UnitTests.csproj reference ./Todo/Todo.csproj
dotnet add package FluentAssertions --version 6.12.0
dotnet add package Moq
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 6.0.0
```

Pour voir les tests dans VSCode : C# Dev Kit

Pour rafraîchir la liste des tests dans VSCode
```bash
dotnet clean
dotnet build
```

## Sources

- [Cours OpenClassrooms - Testez votre application C#](https://openclassrooms.com/fr/courses/5641591-testez-votre-application-c/5656581-decouvrez-les-principes-du-test-driven-development-tdd)
- [C# - how to inject, mock or stub DateTime for unit tests](https://peterdaugaardrasmussen.com/2020/05/16/c-how-to-mock-or-stub-the-datetime-struct-for-tests/)
- [Fluent Assertion](https://fluentassertions.com/)

## Autres

- Behaviour Driven Development Tests avec Specflow