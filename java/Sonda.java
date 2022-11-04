package ejemplo;


import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.util.Base64;
import java.util.Date;
import java.util.Random;

import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;

import java.text.SimpleDateFormat;
import java.time.ZoneOffset;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;
import java.io.Writer;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.security.GeneralSecurityException;
import java.security.InvalidAlgorithmParameterException;
import java.security.InvalidKeyException;
import java.security.KeyException;
import java.security.NoSuchAlgorithmException;


public class Sonda {

    private static final int MAX_VOLUMEN = 100;
    private static final int MAX_LED = 65635;
    private int Volumen;
    private int Led;
    private String UltimaFecha;
    private String fichero = System.getProperty( "catalina.base" ) + "/wtpwebapps/EjemploServiciosWeb/" ;
    private static final String k = "abewqlo1469kstq1";

    
    
    
    public boolean nuevaSonda(String nombre, String usuario, String ip) {
        
    	try {
    		String nombreDecrypt = decrypt(nombre,k);
    		String usuarioDecrypt = decrypt(usuario,k);
    		String ipDecrypt = decrypt(ip,k);
    		logEscribir(nombreDecrypt, usuarioDecrypt, ipDecrypt, "Operacion: Crear nueva Sonda");
    		File file = new File(fichero + "sondas/" + nombreDecrypt + ".txt");
            if(file.exists()){
                leerFichero(usuarioDecrypt);
            }
            else {
                Volumen = randomVolumen();
                Led = randomLed();
                try{
                    file.createNewFile();
                    UltimaFecha = getFecha();
                    String datos = "Volumen=" + Volumen + "\n" +
                                   "Led=" + Led + "\n" +
                                   "UltimaFecha=" + UltimaFecha + "\n";
                    Writer writer = new BufferedWriter(new FileWriter(fichero + "sondas/" + nombreDecrypt + ".txt", true));
                    writer.write(datos);
                    writer.close(); 
                } catch(Exception e){
                    e.printStackTrace();
                }
            }
            return true;
		} catch (GeneralSecurityException | IOException e1) {
			// TODO Auto-generated catch block
		}	
    	return false;
    	
    }
    public int randomVolumen(){
        return new Random().nextInt(MAX_VOLUMEN);
    }
    public int randomLed(){
        return new Random().nextInt(MAX_LED);
    }
    public String getVolumen(String nombre, String usuario, String ip){
    	try {
    		String nombreDecrypt = decrypt(nombre,k);
    		String usuarioDecrypt = decrypt(usuario,k);
    		String ipDecrypt = decrypt(ip,k);
    		logEscribir(nombreDecrypt, usuarioDecrypt, ipDecrypt, "Operacion: GetVolumen");
			leerFichero(nombreDecrypt);
			
		} catch (GeneralSecurityException | IOException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
        try {
        	
			return encrypt("" + Volumen, k);
		} catch (InvalidKeyException | UnsupportedEncodingException | NoSuchAlgorithmException | NoSuchPaddingException
				| InvalidAlgorithmParameterException | IllegalBlockSizeException | BadPaddingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        return null;
    }

    public boolean setLed(String led, String nombre, String usuario, String ip){
    	try {
    		String nombreDecrypt = decrypt(nombre,k);
    		String usuarioDecrypt = decrypt(usuario,k);
    		String ipDecrypt = decrypt(ip,k);
    		logEscribir(nombreDecrypt, usuarioDecrypt, ipDecrypt, "Operacion: SetLed");
			leerFichero(nombreDecrypt);
			int LED;
			try {
				LED = Integer.parseInt(decrypt("" + led, k));
				if(LED > MAX_LED || LED < 0){
		            return false;
		        }
		        else {
		            Led = LED;
		            
		        }
				
			} catch (NumberFormatException | GeneralSecurityException | IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			UltimaFecha = getFecha();
	        modificarFichero(nombreDecrypt);
	        return true;
		} catch (GeneralSecurityException | IOException e1) {
			// TODO Auto-generated catch block
		}
    	return false;

        
        
    }
    public String getLed(String nombre, String usuario, String ip){
    	try {
    		String nombreDecrypt = decrypt(nombre,k);
    		String usuarioDecrypt = decrypt(usuario,k);
    		String ipDecrypt = decrypt(ip,k);
    		logEscribir(nombreDecrypt, usuarioDecrypt, ipDecrypt, "Operacion: GetLed");
			leerFichero(nombreDecrypt);
		} catch (GeneralSecurityException | IOException e1) {
			// TODO Auto-generated catch block
		}

        try {
			return encrypt("" + Led, k);
		} catch (InvalidKeyException | UnsupportedEncodingException | NoSuchAlgorithmException | NoSuchPaddingException
				| InvalidAlgorithmParameterException | IllegalBlockSizeException | BadPaddingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
        
    }
    public String getUltimaFecha(String nombre, String usuario, String ip){
    	try {
    		String nombreDecrypt = decrypt(nombre,k);
    		String usuarioDecrypt = decrypt(usuario,k);
    		String ipDecrypt = decrypt(ip,k);
    		logEscribir(nombreDecrypt, usuarioDecrypt, ipDecrypt, "Operacion: GetUltimaFecha");
			leerFichero(nombreDecrypt);
		} catch (GeneralSecurityException | IOException e1) {
			// TODO Auto-generated catch block
		}
		try {
			return encrypt(UltimaFecha, k);
		} catch (InvalidKeyException | UnsupportedEncodingException | NoSuchAlgorithmException | NoSuchPaddingException
				| InvalidAlgorithmParameterException | IllegalBlockSizeException | BadPaddingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
    }
    public String getFecha(){
        Date date = new Date();
		SimpleDateFormat formatter = new SimpleDateFormat("dd-MM-yyyy HH:mm:ss");
		String fecha = formatter.format(date);
		
		return fecha;
    }
    public void modificarFichero(String nombre){
    	
        try {
        	String datos = "Volumen=" + Volumen + "\n" +
                    	   "Led=" + Led + "\n" +
                    	   "UltimaFecha=" + UltimaFecha + "\n";
        	Files.write(Paths.get(fichero + "sondas/" + nombre + ".txt"), datos.getBytes());
        } catch(Exception e) {
        	System.out.println("Error: " + e);
        }
    }
    public void leerFichero(String nombre){
        try {
                BufferedReader br = new BufferedReader(new FileReader(fichero + "sondas/" + nombre + ".txt"));
                String linea;
                while((linea = br.readLine()) != null) {
                    if(linea.contains("Volumen")) {
                        String[] partes = linea.split("=");
                        Volumen = Integer.parseInt(partes[1]);
                    }
                    else if(linea.contains("Led")) {
                        String[] partes = linea.split("=");
                        Led = Integer.parseInt(partes[1]);
                    }
                    else if(linea.contains("UltimaFecha")) {
                        String[] partes = linea.split("=");
                        UltimaFecha = partes[1];
                    }
                }
                
            } catch (IOException e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
    }
    
    private final String characterEncoding = "UTF-8";
    private final String cipherTransformation = "AES/CBC/PKCS5Padding";
    private final String aesEncryptionAlgorithm = "AES";
    
    public  byte[] decrypt(byte[] cipherText, byte[] key, byte [] initialVector) throws NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException, InvalidAlgorithmParameterException, IllegalBlockSizeException, BadPaddingException
    {
        Cipher cipher = Cipher.getInstance(cipherTransformation);
        SecretKeySpec secretKeySpecy = new SecretKeySpec(key, aesEncryptionAlgorithm);
        IvParameterSpec ivParameterSpec = new IvParameterSpec(initialVector);
        cipher.init(Cipher.DECRYPT_MODE, secretKeySpecy, ivParameterSpec);
        cipherText = cipher.doFinal(cipherText);
        return cipherText;
    }
    
    public byte[] encrypt(byte[] plainText, byte[] key, byte [] initialVector) throws NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException, InvalidAlgorithmParameterException, IllegalBlockSizeException, BadPaddingException
    {
        Cipher cipher = Cipher.getInstance(cipherTransformation);
        SecretKeySpec secretKeySpec = new SecretKeySpec(key, aesEncryptionAlgorithm);
        IvParameterSpec ivParameterSpec = new IvParameterSpec(initialVector);
        cipher.init(Cipher.ENCRYPT_MODE, secretKeySpec, ivParameterSpec);
        plainText = cipher.doFinal(plainText);
        return plainText;
    }
    
    private byte[] getKeyBytes(String key) throws UnsupportedEncodingException{
        byte[] keyBytes= new byte[16];
        byte[] parameterKeyBytes= key.getBytes(characterEncoding);
        System.arraycopy(parameterKeyBytes, 0, keyBytes, 0, Math.min(parameterKeyBytes.length, keyBytes.length));
        return keyBytes;
    }

    
    public String encrypt(String plainText, String key) throws UnsupportedEncodingException, InvalidKeyException, NoSuchAlgorithmException, NoSuchPaddingException, InvalidAlgorithmParameterException, IllegalBlockSizeException, BadPaddingException{
        byte[] plainTextbytes = plainText.getBytes(characterEncoding);
        byte[] keyBytes = getKeyBytes(key);
        return Base64.getEncoder().encodeToString(encrypt(plainTextbytes,keyBytes, keyBytes));

    }

    public String decrypt(String encryptedText, String key) throws KeyException, GeneralSecurityException, GeneralSecurityException, InvalidAlgorithmParameterException, IllegalBlockSizeException, BadPaddingException, IOException{
        byte[] cipheredBytes = Base64.getDecoder().decode(encryptedText);
        byte[] keyBytes = getKeyBytes(key);
        return new String(decrypt(cipheredBytes, keyBytes, keyBytes), characterEncoding);
    }
    
    public boolean logEscribir(String nombre, String usuario, String ip, String datos) {
    	try {
    		File file = new File(fichero + "log/" + nombre + "log.txt");
    		if(file.exists()) {
    			BufferedWriter writer = new BufferedWriter(new FileWriter(file.getAbsoluteFile(), true));
    			ZonedDateTime utc = ZonedDateTime.now(ZoneOffset.UTC);
    			String fecha = utc.format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
    			String linea = "Usuario: " + usuario + ", IP: " + ip + ", Tiempo UTC de la operacion: " + fecha + ", " + datos + "\n";
    			writer.append(linea);
    			writer.close();
    			return true;
    		}
    		else {
    			file.createNewFile();
    			Writer write = new BufferedWriter(new FileWriter(file));
    			ZonedDateTime utc = ZonedDateTime.now(ZoneOffset.UTC);
    			String fecha = utc.format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"));
    			String linea = "Usuario: " + usuario + ", IP: " + ip + ", Tiempo UTC de la operacion: " + fecha + ", " + datos + "\n";
    			write.write(linea);
    			write.close();
    			return true;
    		}
    	}catch (Exception e) {
			// TODO: handle exception
		}
    	return false;
    }
}


