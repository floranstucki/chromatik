<?php

namespace App\Http\Services;
use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Request;
use App\Models\User;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Session;
class RegisterService{


    /**
     * Register a new user
     * @param Request $request the request object containing the user information
     * @return array array contains the token and the email of the user
     */
    public function register (Request $request){
        try{
            $validator = Validator::make($request->all(), [
                'name' => 'required|max:255',
                'first_name' => 'required|string|max:255',
                'phone_number' => 'required|string|max:255',
                'email' => 'required|email|max:255',
                'password' => 'required|string|max:255',
                'c_password' => 'required|same:password'
            ]);
            if ($validator->fails()) {
                throw new HttpResponseException(
                    response()->json($validator->errors(), 422)
                );
            }

            $input = $request -> all();
            $input['password'] = bcrypt($input['password']);
            $user = User::create($input);
            $success['token'] = $user->createToken('token')->plainTextToken;
            $success['email'] = $user->email;
            return $success;
        }catch(\Exception $e){
            throw $e;
        }
    }


    /**
     * Login a user
     * @param Request $request the request object containing the user email and password
     * @return array array contains the token and the user
     */
   public function login(Request $request)
        {
            try {
                if(Auth::attempt(['email' => $request->email, 'password' => $request->password])){
                    $user = Auth::user();
                    $success['token'] =  $user->createToken('token')->plainTextToken;
                    $success['email'] =  $user->email;
                    return $success;
                }

                throw new HttpResponseException(
                    response()->json(['error'=>'Unauthorised'], 403)    
                );

            } catch (\Exception $e) {
                throw ($e);
            }
        }
}