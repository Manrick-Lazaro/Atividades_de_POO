public static int UltimoDia(int mes, int ano){
  int dia = 0;
  switch(mes){
    case 1:
      dia = 31;
      break;
    case 2:
      dia = 28;
      break;
    case 3:
      dia = 31;
      break;
    case 4:
      dia = 30;
      break;
    case 5:
      dia = 31;
      break;
    case 6:
      dia = 30;
      break;
    case 7:
      dia = 31;
      break;
    case 8:
      dia = 31;
      break;
    case 9:
      dia = 30;
      break;
    case 10:
      dia = 31;
      break;
    case 11:
      dia = 30;
      break;
    case 12:
      dia = 31;
      break;
    default:
      break;
  }
  return dia;
}