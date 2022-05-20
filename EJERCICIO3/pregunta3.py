# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
from pyswip import Prolog
prolog= Prolog()

prolog.assertz("abuelo(juan,gladys)")
prolog.assertz("abuelo(juan,mario)")

prolog.assertz("primo(mario,alex)")

list(prolog.query("abuelo(juan,X)"))==[{"X":"gladys"},{"Y":"mario"}]

list(prolog.query("primo(mario,X)"))==[{"X":"alex"},{"Y":"sergio"}]

for elemento in prolog.query("abuelo(X,Y)"): print(elemento["X"],"es el abuelo",elemento["Y"])

for elemento in prolog.query("primo(X,Y)"): print(elemento["X"],"es primo",elemento["Y"])