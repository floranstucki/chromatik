<?php

namespace App\Http\Controllers\Api;

use App\Http\Resources\UserResource;
use App\Http\Services\RegisterService;
use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
class RegisterController extends Controller{

    public function __construct(private RegisterService $_registerService) {}

    /**
     * Register api
     *
     * @return array[]
     */
    public function register(Request $request)
    {
        try {
            return $this->_registerService->register($request);
        } catch (\Exception $e) {
            throw($e);
        }
    }

    /**
     * Login api
     *
     * @return array[]
     */
    public function login(Request $request)
    {
        try {
            return $this->_registerService->login($request);
        } catch (\Exception $e) {
            throw($e);
        }
    }

}