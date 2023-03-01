using System;
using LABORATORIO1_EvelynOneydaReyesMorales.ENTIDADES;
using LABORATORIO1_EvelynOneydaReyesMorales.NEGOCIO;

Persona persona = new Persona();
ClsPersona clsPersona = new ClsPersona();


Console.WriteLine("Ingrese su nombre -> ");
persona.nombre = (Console.ReadLine());

Console.WriteLine("Ingresa tu edad ->");
persona.edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su sexo (M/F) -> ");
persona.sexo = (Console.ReadLine());

Console.WriteLine("Ingresa tu peso en kg ->");
persona.peso = (int)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa tu altura en m ->");
persona.altura = (int)Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Nombre" + ":" + persona.nombre + "       "+"Edad" + ":" + persona.edad + "      " + "Sexo" + ":" + persona.sexo);

Console.WriteLine(clsPersona.Persona(persona));
Console.WriteLine(clsPersona.PersonaEdad(persona));